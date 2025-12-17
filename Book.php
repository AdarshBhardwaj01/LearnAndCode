<?php

class Book {
    private string $title;
    private string $author;
    private int $currentPage = 0;
    private array $pages = [];

    public function __construct(string $title, string $author, array $pages) {
        $this->title = $title;
        $this->author = $author;
        $this->pages = $pages;
    }

    public function getTitle(): string {
        return $this->title;
    }

    public function getAuthor(): string {
        return $this->author;
    }

    public function turnPage(): void {
        if ($this->currentPage < count($this->pages) - 1) {
            $this->currentPage++;
        }
    }

    public function getCurrentPage(): string {
        return $this->pages[$this->currentPage] ?? "";
    }
}

interface Printer {
    public function printPage(string $page): void;
}

class PlainTextPrinter implements Printer {
    public function printPage(string $page): void {
        echo $page;
    }
}

class HtmlPrinter implements Printer {
    public function printPage(string $page): void {
        echo '<div class="single-page">' . htmlspecialchars($page) . '</div>';
    }
}

class BookStorage {
    private string $directory = '/documents/';

    public function save(Book $book): void {
        $filename = $this->directory . $book->getTitle() . '.book';
        file_put_contents($filename, serialize($book));
    }
}


class LibraryLocation {
    private string $shelf;
    private string $room;

    public function __construct(string $shelf, string $room) {
        $this->shelf = $shelf;
        $this->room = $room;
    }

    public function getLocation(): string {
        return "Shelf: {$this->shelf}, Room: {$this->room}";
    }
}
